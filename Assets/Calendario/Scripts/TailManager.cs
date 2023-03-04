using TMPro;
using UnityEditor.EditorTools;
using UnityEngine;

public class TailManager : MonoBehaviour
{
	#region Fields

	[SerializeField]
	private TextMeshProUGUI legend;

	#endregion

	#region Public Methods

	public void SetLegend(string text)
	{
        string loadedString = PlayerPrefs.GetString(text);
        if (loadedString.Length > 1)
        {
            legend.text = loadedString;
        }
		else
		{
			legend.text = text;
		}
	}

	#endregion
}
