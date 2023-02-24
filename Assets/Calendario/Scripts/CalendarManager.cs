using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;

public class CalendarManager : MonoBehaviour
{
	#region Fields

	[SerializeField]
	private HeaderManager headerManager;

	[SerializeField]
	private BodyManager bodyManager;

	[SerializeField]
	private TailManager tailManager;

	private DateTime targetDateTime;
	private CultureInfo cultureInfo;
	string miMes;

	#endregion

	#region Public Methods

	public void OnGoToPreviousOrNextMonthButtonClicked(string param)
	{
		targetDateTime = targetDateTime.AddMonths(param == "Prev" ? -1 : 1);
		Refresh(targetDateTime.Year, targetDateTime.Month);
	}

	#endregion

	#region Private Methods

	private void Start()
	{
		targetDateTime = DateTime.Now;
		cultureInfo = new CultureInfo("es-MX");
		Refresh(targetDateTime.Year, targetDateTime.Month);
	}

	#endregion

	#region Event Handlers

	private void Refresh(int year, int month)
	{
        switch (targetDateTime.Month)
        {
            case 1:
                miMes = "Enero";
                break;
            case 2:
                miMes = "Febrero";
                break;
            case 3:
                miMes = "Marzo";
                break;
            case 4:
                miMes = "Abril";
                break;
            case 5:
                miMes = "Mayo";
                break;
            case 6:
                miMes = "Junio";
                break;
            case 7:
                miMes = "Julio";
                break;
            case 8:
                miMes = "Agosto";
                break;
            case 9:
                miMes = "Septiembre";
                break;
            case 10:
                miMes = "Octubre";
                break;
            case 11:
                miMes = "Noviembre";
                break;
            case 12:
                miMes = "Diciembre";
                break;
            default:
                break;
        }
        headerManager.SetTitle($"{miMes} {year} ");
        //headerManager.SetTitle($"{cultureInfo.DateTimeFormat.GetMonthName(month)} {year} ");
		bodyManager.Initialize(year, month, OnButtonClicked);
	}

	private void OnButtonClicked((string day, string legend) param)
	{
		switch (targetDateTime.Month)
		{
			case 1:
				miMes = "Enero";
				break;
			case 2:
				miMes = "Febrero";
				break;
			case 3:
				miMes = "Marzo";
				break;
            case 4:
                miMes = "Abril";
                break;
            case 5:
                miMes = "Mayo";
                break;
            case 6:
                miMes = "Junio";
                break;
            case 7:
                miMes = "Julio";
                break;
            case 8:
                miMes = "Agosto";
                break;
            case 9:
                miMes = "Septiembre";
                break;
            case 10:
                miMes = "Octubre";
                break;
            case 11:
                miMes = "Noviembre";
                break;
            case 12:
                miMes = "Diciembre";
                break;
            default:
				break;
		}
		tailManager.SetLegend($"Eventos del {param.day} de {miMes}:");
	}

	#endregion
}
