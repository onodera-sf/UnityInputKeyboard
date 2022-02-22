using UnityEngine;
using UnityEngine.InputSystem;  // �ǉ�
using UnityEngine.UI;           // �ǉ�

public class KeyboardPress : MonoBehaviour
{
  /// <summary>��]������e�L�X�g�I�u�W�F�N�g�B</summary>
  [SerializeField] private Text TextObject;

  // �X�V�̓t���[�����Ƃ�1��Ăяo����܂�
  void Update()
  {
    if (TextObject == null)
    {
      Debug.Log($"{nameof(TextObject)} �� null �ł��B");
      return;
    }

    // �L�[�{�[�h�̏����擾
    var keyboard = Keyboard.current;
    if (keyboard == null)
    {
      Debug.Log("�L�[�{�[�h������܂���B");
      return;
    }

    var transform = TextObject.transform;

    // isPressed �͉����Ă���Ԃ͂����� true �ƂȂ�
    // �L�[�́uKeyboard.current[Key.Space]�v�̂悤�Ȏw��̎d��������
    if (keyboard.spaceKey.isPressed)
    {
      transform.Rotate(0, 0, 1);
    }
  }
}
