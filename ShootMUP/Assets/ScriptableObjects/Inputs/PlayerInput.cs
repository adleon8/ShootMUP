//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/ScriptableObjects/Inputs/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerInGameActions"",
            ""id"": ""60516a89-7b21-4c2e-bb00-1cfef60a3e8a"",
            ""actions"": [
                {
                    ""name"": ""WASDMovement"",
                    ""type"": ""Value"",
                    ""id"": ""9491034d-f1e9-4044-aeca-ef252f204421"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ArrowMovement"",
                    ""type"": ""Value"",
                    ""id"": ""ec2584f1-9757-447f-8673-b5f8466a2be4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SpaceLaser"",
                    ""type"": ""Value"",
                    ""id"": ""9639c64b-fd5a-418a-88fa-c8e3e3f90123"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8deb83c6-51c7-4c2f-9123-5752c07ef6b9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASDMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fde9b883-66bd-492f-9c05-203713249390"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASDMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4c4a8e82-68ef-4cd3-878a-d1865f116809"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASDMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""536a1a9e-e25e-400f-834f-4533ae376eb9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""efeb0c62-9c97-45f6-a23e-1e4aa86381be"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""69f564ba-7f82-47ef-9a53-921c36a73151"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4bff08c7-f4a7-4dc0-b43e-d324d6b8ccb5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpaceLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInGameActions
        m_PlayerInGameActions = asset.FindActionMap("PlayerInGameActions", throwIfNotFound: true);
        m_PlayerInGameActions_WASDMovement = m_PlayerInGameActions.FindAction("WASDMovement", throwIfNotFound: true);
        m_PlayerInGameActions_ArrowMovement = m_PlayerInGameActions.FindAction("ArrowMovement", throwIfNotFound: true);
        m_PlayerInGameActions_SpaceLaser = m_PlayerInGameActions.FindAction("SpaceLaser", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerInGameActions
    private readonly InputActionMap m_PlayerInGameActions;
    private List<IPlayerInGameActionsActions> m_PlayerInGameActionsActionsCallbackInterfaces = new List<IPlayerInGameActionsActions>();
    private readonly InputAction m_PlayerInGameActions_WASDMovement;
    private readonly InputAction m_PlayerInGameActions_ArrowMovement;
    private readonly InputAction m_PlayerInGameActions_SpaceLaser;
    public struct PlayerInGameActionsActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerInGameActionsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASDMovement => m_Wrapper.m_PlayerInGameActions_WASDMovement;
        public InputAction @ArrowMovement => m_Wrapper.m_PlayerInGameActions_ArrowMovement;
        public InputAction @SpaceLaser => m_Wrapper.m_PlayerInGameActions_SpaceLaser;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInGameActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInGameActionsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerInGameActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerInGameActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerInGameActionsActionsCallbackInterfaces.Add(instance);
            @WASDMovement.started += instance.OnWASDMovement;
            @WASDMovement.performed += instance.OnWASDMovement;
            @WASDMovement.canceled += instance.OnWASDMovement;
            @ArrowMovement.started += instance.OnArrowMovement;
            @ArrowMovement.performed += instance.OnArrowMovement;
            @ArrowMovement.canceled += instance.OnArrowMovement;
            @SpaceLaser.started += instance.OnSpaceLaser;
            @SpaceLaser.performed += instance.OnSpaceLaser;
            @SpaceLaser.canceled += instance.OnSpaceLaser;
        }

        private void UnregisterCallbacks(IPlayerInGameActionsActions instance)
        {
            @WASDMovement.started -= instance.OnWASDMovement;
            @WASDMovement.performed -= instance.OnWASDMovement;
            @WASDMovement.canceled -= instance.OnWASDMovement;
            @ArrowMovement.started -= instance.OnArrowMovement;
            @ArrowMovement.performed -= instance.OnArrowMovement;
            @ArrowMovement.canceled -= instance.OnArrowMovement;
            @SpaceLaser.started -= instance.OnSpaceLaser;
            @SpaceLaser.performed -= instance.OnSpaceLaser;
            @SpaceLaser.canceled -= instance.OnSpaceLaser;
        }

        public void RemoveCallbacks(IPlayerInGameActionsActions instance)
        {
            if (m_Wrapper.m_PlayerInGameActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerInGameActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerInGameActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerInGameActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerInGameActionsActions @PlayerInGameActions => new PlayerInGameActionsActions(this);
    public interface IPlayerInGameActionsActions
    {
        void OnWASDMovement(InputAction.CallbackContext context);
        void OnArrowMovement(InputAction.CallbackContext context);
        void OnSpaceLaser(InputAction.CallbackContext context);
    }
}
