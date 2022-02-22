using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;  // �ǉ�
using UnityEngine.UI;           // �ǉ�

public class KeyboardAllKeys : MonoBehaviour
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
      TextObject.text = "";
      return;
    }

    // allKeys ���炷�ׂẴL�[�̏��𑖍��� isPressed �ŉ����Ă���L�[�݂̂𒊏o����
    TextObject.text = string.Join(", ", keyboard.allKeys.Where(x => x.isPressed).Select(x => x.keyCode.ToString()));
  }
}
