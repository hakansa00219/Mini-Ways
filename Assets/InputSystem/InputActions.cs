// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d91f2fbf-8e9f-498a-88eb-7839e7301ba7"",
            ""actions"": [
                {
                    ""name"": ""CreateRoad"",
                    ""type"": ""Button"",
                    ""id"": ""8a80dcc2-28ef-4ef0-b34c-6e8b0095823f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CreateBridge"",
                    ""type"": ""Button"",
                    ""id"": ""e39292e6-c82d-4380-9d66-9cf2bf128a23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RemoveGrid"",
                    ""type"": ""Button"",
                    ""id"": ""d5de0737-ad70-4138-8a7a-4817d29eefc9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CreateRoad1"",
                    ""type"": ""Button"",
                    ""id"": ""638085d6-68ee-494f-b7ac-2edf244aa2ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RemoveGrid1"",
                    ""type"": ""Button"",
                    ""id"": ""d399c635-807f-4f30-b630-e625dc01ba34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d98979be-7f6c-469c-9a09-dcd5cc6a43e3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CreateRoad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""855370a4-e912-49f2-b507-31abc190192d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CreateBridge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9df4bb7d-d700-415a-bdc6-14cc7f7864ed"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RemoveGrid"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20eaa1c5-dc7f-4db1-94bd-33694803e78f"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CreateRoad1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7acfb819-a39a-4a16-9170-6cbc538ed89b"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RemoveGrid1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_CreateRoad = m_Player.FindAction("CreateRoad", throwIfNotFound: true);
        m_Player_CreateBridge = m_Player.FindAction("CreateBridge", throwIfNotFound: true);
        m_Player_RemoveGrid = m_Player.FindAction("RemoveGrid", throwIfNotFound: true);
        m_Player_CreateRoad1 = m_Player.FindAction("CreateRoad1", throwIfNotFound: true);
        m_Player_RemoveGrid1 = m_Player.FindAction("RemoveGrid1", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_CreateRoad;
    private readonly InputAction m_Player_CreateBridge;
    private readonly InputAction m_Player_RemoveGrid;
    private readonly InputAction m_Player_CreateRoad1;
    private readonly InputAction m_Player_RemoveGrid1;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @CreateRoad => m_Wrapper.m_Player_CreateRoad;
        public InputAction @CreateBridge => m_Wrapper.m_Player_CreateBridge;
        public InputAction @RemoveGrid => m_Wrapper.m_Player_RemoveGrid;
        public InputAction @CreateRoad1 => m_Wrapper.m_Player_CreateRoad1;
        public InputAction @RemoveGrid1 => m_Wrapper.m_Player_RemoveGrid1;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @CreateRoad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateRoad;
                @CreateRoad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateRoad;
                @CreateRoad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateRoad;
                @CreateBridge.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateBridge;
                @CreateBridge.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateBridge;
                @CreateBridge.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateBridge;
                @RemoveGrid.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveGrid;
                @RemoveGrid.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveGrid;
                @RemoveGrid.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveGrid;
                @CreateRoad1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateRoad1;
                @CreateRoad1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateRoad1;
                @CreateRoad1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCreateRoad1;
                @RemoveGrid1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveGrid1;
                @RemoveGrid1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveGrid1;
                @RemoveGrid1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveGrid1;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CreateRoad.started += instance.OnCreateRoad;
                @CreateRoad.performed += instance.OnCreateRoad;
                @CreateRoad.canceled += instance.OnCreateRoad;
                @CreateBridge.started += instance.OnCreateBridge;
                @CreateBridge.performed += instance.OnCreateBridge;
                @CreateBridge.canceled += instance.OnCreateBridge;
                @RemoveGrid.started += instance.OnRemoveGrid;
                @RemoveGrid.performed += instance.OnRemoveGrid;
                @RemoveGrid.canceled += instance.OnRemoveGrid;
                @CreateRoad1.started += instance.OnCreateRoad1;
                @CreateRoad1.performed += instance.OnCreateRoad1;
                @CreateRoad1.canceled += instance.OnCreateRoad1;
                @RemoveGrid1.started += instance.OnRemoveGrid1;
                @RemoveGrid1.performed += instance.OnRemoveGrid1;
                @RemoveGrid1.canceled += instance.OnRemoveGrid1;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnCreateRoad(InputAction.CallbackContext context);
        void OnCreateBridge(InputAction.CallbackContext context);
        void OnRemoveGrid(InputAction.CallbackContext context);
        void OnCreateRoad1(InputAction.CallbackContext context);
        void OnRemoveGrid1(InputAction.CallbackContext context);
    }
}
