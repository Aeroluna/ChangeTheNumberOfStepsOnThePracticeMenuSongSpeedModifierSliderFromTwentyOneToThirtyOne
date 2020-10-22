namespace ChangeTheNumberOfStepsOnThePracticeMenuSongSpeedModifierSliderFromTwentyOneToThirtyOne
{
    using System.Reflection;
    using HarmonyLib;
    using IPA;

    [Plugin(RuntimeOptions.SingleStartInit)]
    internal class Plugin
    {
        private const string HARMONYID = "com.noodle.BeatSaber.FixPracticeSlider";
        private static readonly Harmony _harmonyInstance = new Harmony(HARMONYID);

        [OnEnable]
        public void OnEnable()
        {
            _harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
