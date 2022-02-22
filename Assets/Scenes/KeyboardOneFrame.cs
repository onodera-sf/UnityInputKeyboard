using UnityEngine;
using UnityEngine.InputSystem;  // 追加
using UnityEngine.UI;           // 追加

public class KeyboardOneFrame : MonoBehaviour
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
      return;
    }

    var transform = TextObject.transform;

    // wasPressedThisFrame は押した瞬間のみ true となる
    // キーは「keyboard[Key.RightArrow]」のような指定の仕方もある
    if (keyboard.leftArrowKey.wasPressedThisFrame)
    {
      transform.Translate(-1, 0, 0);
    }
    if (keyboard.rightArrowKey.wasPressedThisFrame)
    {
      transform.Translate(1, 0, 0);
    }
    if (keyboard.upArrowKey.wasPressedThisFrame)
    {
      transform.Translate(0, 1, 0);
    }
    if (keyboard.downArrowKey.wasPressedThisFrame)
    {
      transform.Translate(0, -1, 0);
    }
  }
}
