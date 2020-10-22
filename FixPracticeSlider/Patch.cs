namespace ChangeTheNumberOfStepsOnThePracticeMenuSongSpeedModifierSliderFromTwentyOneToThirtyOne
{
    using HarmonyLib;
    using HMUI;

    [HarmonyPatch(typeof(PracticeViewController))]
    [HarmonyPatch("Init")]
    internal static class PracticeViewControllerInit
    {
        private static void Postfix(PercentSlider ____speedSlider)
        {
            // 21 => 31
            ____speedSlider.numberOfSteps = 31;
        }
    }
}
