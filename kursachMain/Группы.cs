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
    
    public partial class Группы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Группы()
        {
            this.Студенты = new HashSet<Студенты>();
        }
    
        public int IDГруппы { get; set; }
        public string НомерГруппы { get; set; }
        public string ФИОКуратора { get; set; }
        public string ФИОСтаросты { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Студенты> Студенты { get; set; }
    }
}
