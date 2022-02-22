using UnityEngine;
using UnityEngine.InputSystem;  // 追加
using UnityEngine.UI;           // 追加

public class KeyboardTextInput : MonoBehaviour
{
  /// <summary>移動させるテキストオブジェクト。</summary>
  [SerializeField] private Text TextObject;

  /// <summary>
  /// オブジェクトが有効になったときに呼ばれるイベント。
  /// </summary>
  public void OnEnable()
  {
    // 文字が入力されたときに呼ばれるイベントをセット
    Keyboard.current.onTextInput += OnTextInput;
  }

  /// <summary>
  /// オブジェクトが無効になったときに呼ばれるイベント。
  /// </summary>
  public void OnDisable()
  {
    // 文字が入力されたときに呼ばれるイベントを解除
    Keyboard.current.onTextInput -= OnTextInput;
  }

  /// <summary>
  /// 文字を入力するたびに呼ばれる。
  /// </summary>
  /// <param name="c">入力された文字。</param>
  public void OnTextInput(char c)
  {
    TextObject.text += c;
  }
}
