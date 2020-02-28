using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusDirector : MonoBehaviour
{
    //テキスト
    [SerializeField]
    private List<Text> state;

    //情報の表示
    public void DisplayState(string[] text)
    {
        for(int i=0;i<state.Count;i++)
        {
            state[i].text = text[i];
        }
    }
}
