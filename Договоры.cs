//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SobolevPP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Договоры
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Договоры()
        {
            this.Оплаты = new HashSet<Оплаты>();
        }
    
        public int id { get; set; }
        public int id_клиента { get; set; }
        public Nullable<System.DateTime> Дата_заключения { get; set; }
        public decimal Стоимость { get; set; }
    
        public virtual Клиенты Клиенты { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Оплаты> Оплаты { get; set; }
    }
}
