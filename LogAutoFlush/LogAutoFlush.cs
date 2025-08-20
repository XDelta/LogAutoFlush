using ResoniteModLoader;
using Elements.Core;

namespace ResoniteTestMod;

public class LogAutoFlush : ResoniteMod {
	internal const string VERSION_CONSTANT = "1.0.1";
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

		if (AutoFlush.Value) {
			UniLog.FlushEveryMessage = true;
		}
		AutoFlush.OnChanged += AutoFlush_OnChanged;
	}

	private void AutoFlush_OnChanged(object? newValue) {
		UniLog.FlushEveryMessage = (bool)newValue;
		Msg($"Setting AutoFlush to: {newValue}");
	}
}
