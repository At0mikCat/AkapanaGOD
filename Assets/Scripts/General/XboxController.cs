//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/General/XboxController.inputactions
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

public partial class @XboxController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @XboxController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XboxController"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""32a2d9b9-8ad8-418e-bf60-c6c0d2276945"",
            ""actions"": [
                {
                    ""name"": ""IncreaseStamina"",
                    ""type"": ""Button"",
                    ""id"": ""f0d62e7c-e05e-46cf-a8d7-dbe4b825820a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToLeft"",
                    ""type"": ""Button"",
                    ""id"": ""0c8b486e-3945-4113-849a-80249bbaf15c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToRight"",
                    ""type"": ""Button"",
                    ""id"": ""8f98d82c-e814-465c-b17d-cdd98c28e9f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Ignited"",
                    ""type"": ""Button"",
                    ""id"": ""68cca09b-7f07-4ff9-8830-2e5bc5bfe2b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ExitCredits"",
                    ""type"": ""Button"",
                    ""id"": ""ff434b65-1bbd-442f-95e4-b2d385bf3d3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""4dfae304-3777-4296-8106-7544bfe9397c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""19320204-0d5c-456e-8d72-6696f9cc2577"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseStamina"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c303adb-89ec-4095-bb58-354dac630572"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3b2a0ea-7c98-4e0c-80c1-ae0d007b3b8d"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20625d41-f98d-4574-bc43-4df5aea03ecd"",
                    ""path"": ""<XInputController>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ignited"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""597b7d75-b7b5-4724-9e6c-ccf2362fdae6"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitCredits"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5792570c-c0d2-40ce-9f34-9d380a12f45e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_IncreaseStamina = m_Game.FindAction("IncreaseStamina", throwIfNotFound: true);
        m_Game_ToLeft = m_Game.FindAction("ToLeft", throwIfNotFound: true);
        m_Game_ToRight = m_Game.FindAction("ToRight", throwIfNotFound: true);
        m_Game_Ignited = m_Game.FindAction("Ignited", throwIfNotFound: true);
        m_Game_ExitCredits = m_Game.FindAction("ExitCredits", throwIfNotFound: true);
        m_Game_Pause = m_Game.FindAction("Pause", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private List<IGameActions> m_GameActionsCallbackInterfaces = new List<IGameActions>();
    private readonly InputAction m_Game_IncreaseStamina;
    private readonly InputAction m_Game_ToLeft;
    private readonly InputAction m_Game_ToRight;
    private readonly InputAction m_Game_Ignited;
    private readonly InputAction m_Game_ExitCredits;
    private readonly InputAction m_Game_Pause;
    public struct GameActions
    {
        private @XboxController m_Wrapper;
        public GameActions(@XboxController wrapper) { m_Wrapper = wrapper; }
        public InputAction @IncreaseStamina => m_Wrapper.m_Game_IncreaseStamina;
        public InputAction @ToLeft => m_Wrapper.m_Game_ToLeft;
        public InputAction @ToRight => m_Wrapper.m_Game_ToRight;
        public InputAction @Ignited => m_Wrapper.m_Game_Ignited;
        public InputAction @ExitCredits => m_Wrapper.m_Game_ExitCredits;
        public InputAction @Pause => m_Wrapper.m_Game_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void AddCallbacks(IGameActions instance)
        {
            if (instance == null || m_Wrapper.m_GameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameActionsCallbackInterfaces.Add(instance);
            @IncreaseStamina.started += instance.OnIncreaseStamina;
            @IncreaseStamina.performed += instance.OnIncreaseStamina;
            @IncreaseStamina.canceled += instance.OnIncreaseStamina;
            @ToLeft.started += instance.OnToLeft;
            @ToLeft.performed += instance.OnToLeft;
            @ToLeft.canceled += instance.OnToLeft;
            @ToRight.started += instance.OnToRight;
            @ToRight.performed += instance.OnToRight;
            @ToRight.canceled += instance.OnToRight;
            @Ignited.started += instance.OnIgnited;
            @Ignited.performed += instance.OnIgnited;
            @Ignited.canceled += instance.OnIgnited;
            @ExitCredits.started += instance.OnExitCredits;
            @ExitCredits.performed += instance.OnExitCredits;
            @ExitCredits.canceled += instance.OnExitCredits;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IGameActions instance)
        {
            @IncreaseStamina.started -= instance.OnIncreaseStamina;
            @IncreaseStamina.performed -= instance.OnIncreaseStamina;
            @IncreaseStamina.canceled -= instance.OnIncreaseStamina;
            @ToLeft.started -= instance.OnToLeft;
            @ToLeft.performed -= instance.OnToLeft;
            @ToLeft.canceled -= instance.OnToLeft;
            @ToRight.started -= instance.OnToRight;
            @ToRight.performed -= instance.OnToRight;
            @ToRight.canceled -= instance.OnToRight;
            @Ignited.started -= instance.OnIgnited;
            @Ignited.performed -= instance.OnIgnited;
            @Ignited.canceled -= instance.OnIgnited;
            @ExitCredits.started -= instance.OnExitCredits;
            @ExitCredits.performed -= instance.OnExitCredits;
            @ExitCredits.canceled -= instance.OnExitCredits;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameActions instance)
        {
            foreach (var item in m_Wrapper.m_GameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameActions @Game => new GameActions(this);
    public interface IGameActions
    {
        void OnIncreaseStamina(InputAction.CallbackContext context);
        void OnToLeft(InputAction.CallbackContext context);
        void OnToRight(InputAction.CallbackContext context);
        void OnIgnited(InputAction.CallbackContext context);
        void OnExitCredits(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
