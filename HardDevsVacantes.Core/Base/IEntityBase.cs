using System;
namespace HardDevsVacantes.Core.Base
{
	public interface IEntityBase
	{
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}

