using System;
using Microsoft.Bot.Builder.FormFlow;

public enum Section { IS = 1, CTI, CTIEN, INFO, Secret };
public enum YearOfStudy { One = 1, Two, Three, Four, Master, PhD, Secret };

// For more information about this template visit http://aka.ms/azurebots-csharp-form
[Serializable]
public class BasicForm
{
    [Prompt("Hi! What is your {&}? (Please write a message, one line only :) )")]
    public string Crush { get; set; }

    [Prompt("What year are you? {&} {||}")]
    public YearOfStudy Year { get; set; }

    [Prompt("What section are you in? {||}")]
    public Section StudySection { get; set; }

    public static IForm<BasicForm> BuildForm()
    {
        // Builds an IForm<T> based on BasicForm
        return new FormBuilder<BasicForm>().Build();
    }

    public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
    {
        // Generated a new FormDialog<T> based on IForm<BasicForm>
        return FormDialog.FromForm(BuildForm, options);
    }
}
