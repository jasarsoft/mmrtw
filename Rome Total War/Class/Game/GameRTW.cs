using System;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class GameRTW : GameTW
    {
        public GameRTW() : base()
        {
            GameName name = new GameName();
            GamePath path = new GamePath();
            GameTitle title = new GameTitle();

            this.Name = name.NameRTW;
            this.Path = path.PathRTW;
            this.Type = GameType.GameRTW;
            this.Title = title.TitleRTW;
            this.Size = GetSize();
            this.Version = GetVersion();
        }
    }
}
