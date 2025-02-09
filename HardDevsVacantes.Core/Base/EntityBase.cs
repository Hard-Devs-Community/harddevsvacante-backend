using System;
namespace HardDevsVacantes.Core.Base
{
	public class EntityBase : IEntityBase
	{
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}

