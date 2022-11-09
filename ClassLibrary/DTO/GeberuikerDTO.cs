using Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class GeberuikerDTO
    {

        string Naam { get; set; }
        string Email { get; set; }
        string Wachtwoord { get; set; }
        Rol Rol { get; set; }

    }
}
