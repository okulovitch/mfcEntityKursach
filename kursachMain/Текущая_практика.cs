//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kursachMain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Текущая_практика
    {
        public int IDТекущейПрактики { get; set; }
        public int IDДоговора { get; set; }
        public int IDВидаПрактики { get; set; }
        public int IDПреподавателя { get; set; }
    
        public virtual Виды_практики Виды_практики { get; set; }
        public virtual Договоры Договоры { get; set; }
        public virtual Преподаватели Преподаватели { get; set; }
    }
}
