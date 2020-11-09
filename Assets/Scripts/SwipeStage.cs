using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeStage : MonoBehaviour
{
    int n;
    public GameObject scrollbar;
    float scroll_pos = 0;
    float[] pos;
    public Text StageText;
    string [] stageName = new string[] { "화성", "목성", "토성", "천왕성", "해왕성", "명왕성" };

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++) {
            pos[i] = distance * i;
        }
        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        }
        else {
            for (int i = 0; i < pos.Length; i++) {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2)){
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                }
            }
        }

        for (int i = 0; i < pos.Length; i++)
        {
            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
            {
                n = 5 - i;
                SetStageText(i);
                transform.GetChild(n).localScale = Vector2.Lerp(transform.GetChild(n).localScale, new Vector2(1f, 1f), 0.25f);
                for (int a = 0; a < pos.Length; a++) {
                    if (a != i) {
                        transform.GetChild(a).localScale = Vector2.Lerp(transform.GetChild(a).localScale, new Vector2(0.8f, 0.8f), 0.1f);
                    }
                }
            }
        }
    }

    void SetStageText(int stage) {
        StageText.text = "Stage" + (stage + 1) + "\n" + stageName[stage];
    }
}
