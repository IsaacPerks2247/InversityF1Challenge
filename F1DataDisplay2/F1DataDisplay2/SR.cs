using System;
using System.IO;

public class SR//SubRoutines
{
	public SR()
	{
	}
    public static string[] GetCarData()
    {
        string path = "C:\\Users\\ilp.2302941\\OneDrive - wsfc.ac.uk\\Documents\\NewDocuments\\EducationAndWork\\Worcester6thForm\\Inversity\\F1Challenge\\winFormsVers\\F1DataDisplay\\firstCarData.txt";
        string readData = File.ReadAllText(path)
            .Replace("{", "")
            .Replace("}", "")
            .Replace(":", "")
            .Replace(" ", "");

        string[] dataArr = readData.Split(',');
        for (int i = 0; i < dataArr.Length; i++)//gets rid of the unnecessary string values and add to array
        {
            string tempString = "";
            for (int j = 0; j < dataArr[i].Length; j++)
            {
                if (isInAplphabet(dataArr[i][j]) == false)
                {
                    tempString += dataArr[i][j];
                }
            }
            dataArr[i] = tempString;

        }

        //set up: [meetingkey, sessionkey, drivernumber, date, rpm, speed, gear, throttle, drs, brake]
        return dataArr;
        //return $"{dataArr[0]}#{dataArr[1]}#{dataArr[2]}#{dataArr[3]}#{dataArr[4]}#{dataArr[5]}#{dataArr[6]}#{dataArr[7]}#{dataArr[8]}#{dataArr[9]}";
    }
    public static bool isInAplphabet(char toCheck)
    {
        string alpha = "abcdefghijklmnopqrstuvwxyz'_ACDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char c in alpha)
        {
            if (c == toCheck)
            {
                return true;
            }
        }
        return false;
    }
}
