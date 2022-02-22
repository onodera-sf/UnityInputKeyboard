using UnityEngine;
using UnityEngine.InputSystem;  // 追加
using UnityEngine.UI;           // 追加

public class KeyboardPress : MonoBehaviour
{
  /// <summary>回転させるテキストオブジェクト。</summary>
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
      return;
    }

    var transform = TextObject.transform;

    // isPressed は押している間はずっと true となる
    // キーは「Keyboard.current[Key.Space]」のような指定の仕方もある
    if (keyboard.spaceKey.isPressed)
    {
      transform.Rotate(0, 0, 1);
    }
  }
}
