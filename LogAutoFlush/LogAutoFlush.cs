using ResoniteModLoader;

namespace ResoniteTestMod;

public class LogAutoFlush : ResoniteMod {
	internal const string VERSION_CONSTANT = "1.0.0";
	public override string Name => "LogAutoFlush";
	public override string Author => "Delta";
	public override string Version => VERSION_CONSTANT;
	public override string Link => "https://github.com/XDelta/LogAutoFlush";

	[AutoRegisterConfigKey]
	private static readonly ModConfigurationKey<bool> AutoFlush = new("AutoFlush", "Enable AutoFlushing the logs", () => false);

	internal static ModConfiguration Config;

	public override void OnEngineInit() {
		Config = GetConfiguration();
		Config.Save(true);

		Msg($"Current AutoFlush Setting: {FrooxEngineBootstrap.LogStream.AutoFlush}");
		if (Config.GetValue(AutoFlush)) {
			FrooxEngineBootstrap.LogStream.AutoFlush = true;
		}

		AutoFlush.OnChanged += AutoFlush_OnChanged;
	}

	private void AutoFlush_OnChanged(object? newValue) {
		FrooxEngineBootstrap.LogStream.AutoFlush = (bool)newValue;
		Msg($"Setting AutoFlush to: {newValue}");
	}
}
