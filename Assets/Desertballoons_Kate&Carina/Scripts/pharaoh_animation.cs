using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class pharaoh_animation : MonoBehaviour
{
    public empty_1 em1;
    public empty_2 em2;
    public empty_3 em3;
    public empty_4 em4;
    public empty_5 em5;
    public empty_6 em6;

    Animator anim;

    public int nextlevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        nextlevel = em1.Score + em2.Score2 + em3.Score3 + em4.Score4 + em5.Score5 + em6.Score6;

        if (nextlevel == 6) {

            anim.SetBool("SetBool", true);

        }
    }

    public void GoOn()
    {
        SceneManager.LoadScene("final");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
