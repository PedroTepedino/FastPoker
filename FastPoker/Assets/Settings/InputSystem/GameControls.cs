// GENERATED AUTOMATICALLY FROM 'Assets/Settings/InputSystem/GameControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""Controls"",
            ""id"": ""4e9cd95c-8b44-48dd-9307-34733713fbf8"",
            ""actions"": [
                {
                    ""name"": ""ChangeCard"",
                    ""type"": ""Button"",
                    ""id"": ""1ebd0b4d-ef6d-4b47-abba-151fa3781a9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aaa19e69-a3e0-4047-a259-700be66fdb3a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controls
        m_Controls = asset.FindActionMap("Controls", throwIfNotFound: true);
        m_Controls_ChangeCard = m_Controls.FindAction("ChangeCard", throwIfNotFound: true);
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

    // Controls
    private readonly InputActionMap m_Controls;
    private IControlsActions m_ControlsActionsCallbackInterface;
    private readonly InputAction m_Controls_ChangeCard;
    public struct ControlsActions
    {
        private @GameControls m_Wrapper;
        public ControlsActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeCard => m_Wrapper.m_Controls_ChangeCard;
        public InputActionMap Get() { return m_Wrapper.m_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IControlsActions instance)
        {
            if (m_Wrapper.m_ControlsActionsCallbackInterface != null)
            {
                @ChangeCard.started -= m_Wrapper.m_ControlsActionsCallbackInterface.OnChangeCard;
                @ChangeCard.performed -= m_Wrapper.m_ControlsActionsCallbackInterface.OnChangeCard;
                @ChangeCard.canceled -= m_Wrapper.m_ControlsActionsCallbackInterface.OnChangeCard;
            }
            m_Wrapper.m_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeCard.started += instance.OnChangeCard;
                @ChangeCard.performed += instance.OnChangeCard;
                @ChangeCard.canceled += instance.OnChangeCard;
            }
        }
    }
    public ControlsActions @Controls => new ControlsActions(this);
    public interface IControlsActions
    {
        void OnChangeCard(InputAction.CallbackContext context);
    }
}
