using UnityEngine;
using System.Collections;

/**
 * フレームレート測定モニタ
 */
public class FpsMonitor : MonoBehaviour
{

    //測定用
    int tick = 0;             //フレーム数
    float elapsed = 0;        //経過時間
    float fps = 0;            //フレームレート

    //外観設定
    const float GUI_WIDTH = 75f;     //GUI矩形幅
    const float GUI_HEIGHT = 30f;    //GUI矩形高さ
    const float MARGIN_X = 10f;      //画面からの横マージン
    const float MARGIN_Y = 10f;      //画面からの縦マージン
    const float INNER_X = 8f;        //文字のGUI外枠からの横マージン
    const float INNER_Y = 5f;        //文字のGUI外枠からの縦マージン

    Rect outer;        //外枠(GUI矩形領域)
    Rect inner;        //内枠(文字領域)

    // Use this for initialization
    void Start() {
        outer = new Rect(MARGIN_X, MARGIN_Y, GUI_WIDTH, GUI_HEIGHT);
        inner = new Rect(MARGIN_X + INNER_X, MARGIN_Y + INNER_Y, GUI_WIDTH - INNER_X * 2f, GUI_HEIGHT - INNER_Y * 2f);
    }

    // Update is called once per frame
    void Update() {
        tick++;
        elapsed += Time.deltaTime;
        if (elapsed >= 1f) {
            fps = tick / elapsed;
            tick = 0;
            elapsed = 0;
        }
    }

    void OnGUI() {
        GUI.Box(outer, "");
        GUILayout.BeginArea(inner);
        {
            GUILayout.BeginVertical();
            GUILayout.Label("fps : " + fps.ToString("F1"));
            GUILayout.EndVertical();
        }
        GUILayout.EndArea();
    }
}