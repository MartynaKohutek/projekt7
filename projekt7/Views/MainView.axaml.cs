using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Metadata;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;


namespace projekt7.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Click!");
        Dictionary<string, int> licznik = new Dictionary<string, int>();
        List<string> lista = new List<string>();
        for (int i = 0; i < input.Text.Length-4; i++)
        {
            lista.Add(input.Text.Substring(i, 4));
           
            if (licznik.ContainsKey(input.Text.Substring(i, 4)))
            {
                licznik[input.Text.Substring(i, 4)]++;
            }
            else
            {
                licznik.Add(input.Text.Substring(i, 4), 1);
            }
        }
        foreach(string d in licznik.Keys)
        {
            output.Text += d + " " + licznik[d].ToString();
            output.Text += ("\n");
        }
        
           
    }
}


