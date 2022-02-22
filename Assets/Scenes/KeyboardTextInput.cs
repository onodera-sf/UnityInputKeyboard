using UnityEngine;
using UnityEngine.InputSystem;  // �ǉ�
using UnityEngine.UI;           // �ǉ�

public class KeyboardTextInput : MonoBehaviour
{
  /// <summary>�ړ�������e�L�X�g�I�u�W�F�N�g�B</summary>
  [SerializeField] private Text TextObject;

  /// <summary>
  /// �I�u�W�F�N�g���L���ɂȂ����Ƃ��ɌĂ΂��C�x���g�B
  /// </summary>
  public void OnEnable()
  {
    // ���������͂��ꂽ�Ƃ��ɌĂ΂��C�x���g���Z�b�g
    Keyboard.current.onTextInput += OnTextInput;
  }

  /// <summary>
  /// �I�u�W�F�N�g�������ɂȂ����Ƃ��ɌĂ΂��C�x���g�B
  /// </summary>
  public void OnDisable()
  {
    // ���������͂��ꂽ�Ƃ��ɌĂ΂��C�x���g������
    Keyboard.current.onTextInput -= OnTextInput;
  }

  /// <summary>
  /// ��������͂��邽�тɌĂ΂��B
  /// </summary>
  /// <param name="c">���͂��ꂽ�����B</param>
  public void OnTextInput(char c)
  {
    TextObject.text += c;
  }
}
