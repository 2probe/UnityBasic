using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text; //�ؽ�Ʈ�� ���� ��
    [SerializeField] TMP_InputField Input_Text; // ��� �ؽ�Ʈ�� ������ �� ��

    public void OnClickButton()
    {
        Txt_Text.text = Input_Text.text; // ��ư�� Ŭ������ �� Input_Text�� �ؽ�Ʈ�� Txt_Text�� �ִ´�.
    }
}
