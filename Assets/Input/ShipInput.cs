// GENERATED AUTOMATICALLY FROM 'Assets/Input/ShipInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ShipInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ShipInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ShipInput"",
    ""maps"": [
        {
            ""name"": ""Ship Controls"",
            ""id"": ""761128c0-9745-4d07-9934-459948eb7d58"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0667abc5-d378-4628-99c5-67071fe86d1b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throttle"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6fdca27b-b0b7-4055-94d9-b5a156ef3d0e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4756aa3a-69a3-4d4f-a8f0-e805739535ef"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FreeLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6879cf22-d3e2-42f2-a4c9-85a7fb93ea54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire Primary"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aaa82c57-a49a-4c53-b948-8ee771daa48a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3e245237-2035-4c1d-95d7-a9eed2c9a10a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""48ae0cf9-cadd-42a3-8222-8081d538bca6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5b4594d0-95e9-4fd9-93fe-543b6aa5bc24"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5cb08208-b132-4233-9d70-8afd443a6694"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a97cfaaa-10ae-418a-94f8-af74dd8bfed0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e704f13f-7a87-471a-a7fc-6238d8417a15"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""29992c0e-425f-4ecc-ab70-cad4d8f5af9e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""afa1e01b-4956-4204-8c03-59663ecb7a72"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FreeLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e8551af-08c3-4c6e-8da5-00f2062f9343"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire Primary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ship Controls
        m_ShipControls = asset.FindActionMap("Ship Controls", throwIfNotFound: true);
        m_ShipControls_Mouse = m_ShipControls.FindAction("Mouse", throwIfNotFound: true);
        m_ShipControls_Throttle = m_ShipControls.FindAction("Throttle", throwIfNotFound: true);
        m_ShipControls_AD = m_ShipControls.FindAction("AD", throwIfNotFound: true);
        m_ShipControls_FreeLook = m_ShipControls.FindAction("FreeLook", throwIfNotFound: true);
        m_ShipControls_FirePrimary = m_ShipControls.FindAction("Fire Primary", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Ship Controls
    private readonly InputActionMap m_ShipControls;
    private IShipControlsActions m_ShipControlsActionsCallbackInterface;
    private readonly InputAction m_ShipControls_Mouse;
    private readonly InputAction m_ShipControls_Throttle;
    private readonly InputAction m_ShipControls_AD;
    private readonly InputAction m_ShipControls_FreeLook;
    private readonly InputAction m_ShipControls_FirePrimary;
    public struct ShipControlsActions
    {
        private @ShipInput m_Wrapper;
        public ShipControlsActions(@ShipInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_ShipControls_Mouse;
        public InputAction @Throttle => m_Wrapper.m_ShipControls_Throttle;
        public InputAction @AD => m_Wrapper.m_ShipControls_AD;
        public InputAction @FreeLook => m_Wrapper.m_ShipControls_FreeLook;
        public InputAction @FirePrimary => m_Wrapper.m_ShipControls_FirePrimary;
        public InputActionMap Get() { return m_Wrapper.m_ShipControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipControlsActions set) { return set.Get(); }
        public void SetCallbacks(IShipControlsActions instance)
        {
            if (m_Wrapper.m_ShipControlsActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouse;
                @Throttle.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnThrottle;
                @AD.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnAD;
                @AD.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnAD;
                @AD.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnAD;
                @FreeLook.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFreeLook;
                @FreeLook.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFreeLook;
                @FreeLook.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFreeLook;
                @FirePrimary.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFirePrimary;
                @FirePrimary.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFirePrimary;
                @FirePrimary.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnFirePrimary;
            }
            m_Wrapper.m_ShipControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @AD.started += instance.OnAD;
                @AD.performed += instance.OnAD;
                @AD.canceled += instance.OnAD;
                @FreeLook.started += instance.OnFreeLook;
                @FreeLook.performed += instance.OnFreeLook;
                @FreeLook.canceled += instance.OnFreeLook;
                @FirePrimary.started += instance.OnFirePrimary;
                @FirePrimary.performed += instance.OnFirePrimary;
                @FirePrimary.canceled += instance.OnFirePrimary;
            }
        }
    }
    public ShipControlsActions @ShipControls => new ShipControlsActions(this);
    public interface IShipControlsActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnThrottle(InputAction.CallbackContext context);
        void OnAD(InputAction.CallbackContext context);
        void OnFreeLook(InputAction.CallbackContext context);
        void OnFirePrimary(InputAction.CallbackContext context);
    }
}
