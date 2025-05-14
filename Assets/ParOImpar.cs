using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParOImpar : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TextMeshProUGUI txtParOImpar;
    int num1;

    // Start is called before the first frame update
    void Start()
    {
        txtParOImpar.text = string.Empty;
    }

    public void EsParONo()
    {
        if (inputNum1.text == "")
        {
            txtParOImpar.text = "El campo está vacío";
            return;
        }

        num1 = int.Parse(inputNum1.text);

        if (num1 <= 0)
        {
            txtParOImpar.text = "El nro debe ser mayor que cero";
            return;
        }

        if (num1 % 2 == 0)
        {
            txtParOImpar.text = "El número es par";
        }
        else
        {
            txtParOImpar.text = "El número es impar";
        }
    }

}
