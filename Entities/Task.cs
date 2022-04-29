using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class Task
    {
        public Task()
        {
            TaskItems = new HashSet<TaskItem>();
        }

        public Guid TaskID { get; set; }
        public int StoreID { get; set; }
        public short LastTaskIndex { get; set; }

        public virtual ICollection<TaskItem> TaskItems { get; set; }
    }
}
