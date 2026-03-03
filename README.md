# LogAutoFlush
A [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) mod for [Resonite](https://resonite.com/) that allows enabling `UniLog.FlushEveryMessage` and write to file immmediately instead of buffering writes. This will causes IO writes to happen significantly more frequently while enabled but when debugging, seeing the full log line instead of one that is partially cut off is worth the trade off.

You must manually enable the `AutoFlush` setting for this to function. It is intentionally disabled by default.

Resonite Issue to implement a launch option to enable: https://github.com/Yellow-Dog-Man/Resonite-Issues/issues/6315

## Installation
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
1. Place [LogAutoFlush.dll](https://github.com/XDelta/LogAutoFlush/releases/latest/download/LogAutoFlush.dll) into your `rml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\Resonite\rml_mods` for a default install. You can create it if it's missing, or if you launch the game once with ResoniteModLoader installed it will create this folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Resonite logs.

## Config Options

| Config Option     | Default | Description |
| ------------------ | ------- | ----------- |
| `AutoFlush` | `false` | Enable auto flushing the logs |
