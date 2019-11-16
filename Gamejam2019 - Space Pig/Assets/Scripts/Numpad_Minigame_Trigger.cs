using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numpad_Minigame_Trigger : MonoBehaviour
{
    public SphereCollider trigger_button;

    // Start is called before the first frame update
    void Start()
    {
        trigger_button = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (trigger_button.name)
            {
                case "Button_1":
                    Numpad_Minigame_Codes.input_code += "1";
                    break;
                case "Button_2":
                    Numpad_Minigame_Codes.input_code += "2";
                    break;
                case "Button_3":
                    Numpad_Minigame_Codes.input_code += "3";
                    break;
                case "Button_4":
                    Numpad_Minigame_Codes.input_code += "4";
                    break;
                case "Button_5":
                    Numpad_Minigame_Codes.input_code += "5";
                    break;
                case "Button_6":
                    Numpad_Minigame_Codes.input_code += "6";
                    break;
                case "Button_7":
                    Numpad_Minigame_Codes.input_code += "7";
                    break;
                case "Button_8":
                    Numpad_Minigame_Codes.input_code += "8";
                    break;
                case "Button_9":
                    Numpad_Minigame_Codes.input_code += "9";
                    break;
                case "Button_0":
                    Numpad_Minigame_Codes.input_code += "0";
                    break;
                case "Button_Star":
                    break;
                case "Button_Pound":
                    break;
                case "Button_AlertGuards1":
                    break;
                case "Button_AlertGuards2":
                    break;

                default:
                    break;
            }
            Debug.Log(trigger_button.name);
        }

    }
}
