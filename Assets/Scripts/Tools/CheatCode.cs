using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class CheatCode : MonoBehaviour
{

    public string code;
    public UnityEvent onCodeEntered;
    protected int current;

    void Update()
    {
        if (Input.anyKeyDown) {
            if (Input.GetKeyDown(code [current].ToString())) {
                current++;
                
                if (current >= code.Length) {
                    current = 0;
                    onCodeEntered.Invoke();
                }
                
            } else {
                current = 0;
            }
        }
    }
}