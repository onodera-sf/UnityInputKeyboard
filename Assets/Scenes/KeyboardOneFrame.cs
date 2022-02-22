using UnityEngine;
using UnityEngine.InputSystem;  // �ǉ�
using UnityEngine.UI;           // �ǉ�

public class KeyboardOneFrame : MonoBehaviour
{
  /// <summary>�ړ�������e�L�X�g�I�u�W�F�N�g�B</summary>
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

    // wasPressedThisFrame �͉������u�Ԃ̂� true �ƂȂ�
    // �L�[�́ukeyboard[Key.RightArrow]�v�̂悤�Ȏw��̎d��������
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
