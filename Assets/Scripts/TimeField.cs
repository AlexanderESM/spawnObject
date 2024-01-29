using UnityEngine.UI;
using UnityEngine;

public class TimeField : MonoBehaviour
{

    //������� ��������� �������
    //�������� ������� �������� �� GUI � ��������� ���� Time (InputField)
    public InputField inpuTimetField;
    private string strValue;

    //���������� � ������� Gun
    public static int intTime =0;

    private void Start()
    {
        inpuTimetField.text = "0";

        if (inpuTimetField != null)
        {
           // Debug.Log("# 1 SpeedField ####");
            // ��������� ��������� �� ������� ��������� �������� � ��������� ����
            inpuTimetField.onValueChanged.AddListener(OnInputFieldValueChanged);
        }
    }

    private void OnInputFieldValueChanged(string inputValue)
    {
        //Debug.Log(" # 2 Distance ####= " + inputValue);
        //������� �������
        strValue = RemoveSpaces(inputValue);
        //Debug.Log(" # 3 Distance strValue = " + strValue);

        //��������� ���� ������ ����
        if (IsInputFieldNumeric(strValue))
        {
            //Debug.Log("�� ������� ��������� ������� speed=" + strValue);
            intTime = ConvertStringToInt(strValue);
        }
        else
        {
            // ���� ������ �� �������� ������, ������� ���� �����
            inpuTimetField.text = "0";
            intTime = 0;
        }


    }

    //������� �������
    private string RemoveSpaces(string inputValue)
    {
        return inputValue.Replace(" ", "");
    }

    // ���������, ��� ��������� ������ �������� ������
    private bool IsInputFieldNumeric(string inputValue)
    {
        foreach (char c in inputValue)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }

    //�� ����������� ���� � int
    private int ConvertStringToInt(string inputString)
    {
        try
        {
            // �������������� ������ � int
            //int newIntValue = int.Parse(inputString);
            //speed = newIntValue;
            return int.Parse(inputString);
            // ����������� �������� intValue �� ������ ����������
            //Debug.Log("# 2 Converted string to int: " + newIntValue);

        }
        catch (System.Exception ex)
        {
            // newIntValue = 0;
            // ��������� ������ ��� ��������������
           // Debug.LogError("# 3 Error converting string to int: " + ex.Message);
            return 1;

        }

    }


}
