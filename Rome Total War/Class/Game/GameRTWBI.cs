using System;
using System.Collections.Generic;
using System.Text;

namespace Jasarsoft.ModManager.RomeTotalWar
{
    internal sealed class GameRTWBI : GameTW
    {
        public GameRTWBI() : base()
        {
            GameName name = new GameName();
            GamePath path = new GamePath();
            GameTitle title = new GameTitle();

            this.Name = name.NameRTWBI;
            this.Path = path.PathRTWBI;
            this.Type = GameType.GameRTWBI;
            this.Title = title.TitleRTWBI;
            this.Size = GetSize();
            this.Version = GetVersion();
        }
    }
}
