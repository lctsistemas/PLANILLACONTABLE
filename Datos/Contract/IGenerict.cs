using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace Datos.Contract
{
    public interface IGenerict<Entity> where Entity:class
    {
        Int32 Add(Entity entiti);
        Int32 Edit(Entity entiti);
        Int32 Delete(Entity entiti);
        DataTable GetData(Entity entiti);
        
    }
}
