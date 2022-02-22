using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;  // 追加
using UnityEngine.UI;           // 追加

public class KeyboardAllKeys : MonoBehaviour
{
  /// <summary>移動させるテキストオブジェクト。</summary>
  [SerializeField] private Text TextObject;

  // 更新はフレームごとに1回呼び出されます
  void Update()
  {
    if (TextObject == null)
    {
      Debug.Log($"{nameof(TextObject)} が null です。");
      return;
    }

    // キーボードの情報を取得
    var keyboard = Keyboard.current;
    if (keyboard == null)
    {
      Debug.Log("キーボードがありません。");
      TextObject.text = "";
      return;
    }

    // allKeys からすべてのキーの情報を走査し isPressed で押しているキーのみを抽出する
    TextObject.text = string.Join(", ", keyboard.allKeys.Where(x => x.isPressed).Select(x => x.keyCode.ToString()));
  }
}
