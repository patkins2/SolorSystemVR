using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR;

public class VRInput : BaseInputModule
{
    public Camera cam;
    public SteamVR_Input_Sources TargetSource;
    public SteamVR_Action_Boolean ClickAction;

    private GameObject currentObject = null;
    private PointerEventData Data = null;

    protected override void Awake()
    {
        base.Awake();

        Data = new PointerEventData(eventSystem);
    }

    public override void Process()
    {
        Data.Reset();
        Data.position = new Vector2(cam.pixelWidth / 2, cam.pixelHeight / 2);

        eventSystem.RaycastAll(Data, m_RaycastResultCache);
        Data.pointerCurrentRaycast = FindFirstRaycast(m_RaycastResultCache);
        currentObject = Data.pointerCurrentRaycast.gameObject;

        m_RaycastResultCache.Clear();

        HandlePointerExitAndEnter(Data, currentObject);

        if (ClickAction.GetStateDown(TargetSource))
            ProcessPress(Data);

        if (ClickAction.GetStateUp(TargetSource))
            ProcessRelease(Data);
    }

    public PointerEventData GetData()
    {
        return Data;
    }

    private void ProcessPress(PointerEventData _data)
    {
        _data.pointerPressRaycast = _data.pointerCurrentRaycast;

        GameObject newPointerPress = ExecuteEvents.ExecuteHierarchy(currentObject, _data, ExecuteEvents.pointerDownHandler);

        if (newPointerPress == null)
            newPointerPress = ExecuteEvents.GetEventHandler<IPointerClickHandler>(currentObject);

        _data.pressPosition = _data.position;
        _data.pointerPress = newPointerPress;
        _data.rawPointerPress = currentObject;
    }

    private void ProcessRelease(PointerEventData _data)
    {
        ExecuteEvents.Execute(_data.pointerPress, _data, ExecuteEvents.pointerUpHandler);

        GameObject pointerUpHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(currentObject);

        if (_data.pointerPress == pointerUpHandler)
            ExecuteEvents.Execute(_data.pointerPress, _data, ExecuteEvents.pointerClickHandler);

        eventSystem.SetSelectedGameObject(null);

        _data.pressPosition = Vector2.zero;
        _data.pointerPress = null;
        _data.rawPointerPress = null;
    }
}
