using UnityEngine.UI;
using UnityEngine;

public class Distance : MonoBehaviour
{
    //Время жизни объекта, типа дистанция
    // получаем введёное значение на GUI в текстовое поле Time (InputField)
    public InputField inpuTimetField;
    
    private string strValue;

    //используем в скрипте Bullet дистанция = время жизни объекта
    public static int intDistance=0;

    private void Start()
    {
        inpuTimetField.text = "0";
       

        if (inpuTimetField != null)
        {
           // Debug.Log("# 1 Distance ####");
            // Добавляем слушатель на событие изменения значения в текстовом поле
            inpuTimetField.onValueChanged.AddListener(OnInputFieldValueChanged);
        }
    }



    private void OnInputFieldValueChanged(string inputValue)
    {
        //Debug.Log(" # 2 Distance ####= " + inputValue);
        //убираем пробелы
        strValue = RemoveSpaces(inputValue);
        //Debug.Log(" # 3 Distance strValue = " + strValue);

        //разрешаем ввод только цифр
        if (IsInputFieldNumeric(strValue))
        {
            //Debug.Log("Из скрипта провереок передаём speed=" + strValue);
            intDistance= ConvertStringToInt(strValue);
        }
        else
        {
            // Если символ не является цифрой, очищаем поле ввода
            inpuTimetField.text = "0";
            intDistance = 0;

        }


    }

    //удаляем пробелы
    private string RemoveSpaces(string inputValue)
    {
        return inputValue.Replace(" ", "");
    }

    // Проверяем, что введенный символ является цифрой
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

    //из текстововго поля в int
    private int  ConvertStringToInt(string inputString)
    {
       try
        {
            // преобразование строки в int
            //int newIntValue = int.Parse(inputString);
            //speed = newIntValue;
            return int.Parse(inputString);
            // Используйте значение intValue по вашему усмотрению
            //Debug.Log("# 2 Converted string to int: " + newIntValue);

        }
        catch (System.Exception ex)
        {
            // newIntValue = 0;
            // Обработка ошибок при преобразовании
           // Debug.LogError("# 3 Error converting string to int: " + ex.Message);
            return 1;

        }

    }


}
