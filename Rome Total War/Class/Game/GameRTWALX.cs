using System;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class GameRTWALX : GameTW
    {
        public GameRTWALX() : base()
        {
            GameName name = new GameName();
            GamePath path = new GamePath();
            GameTitle title = new GameTitle();

            this.Name = name.NameRTWALX;
            this.Path = path.PathRTWALX;
            this.Type = GameType.GameRTWALX;
            this.Title = title.TitleRTWALX;
            this.Size = GetSize();
            this.Version = GetVersion();
        }
    }
}
