using DiskManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiskManagement.Controllers
{
    public class DiskService
    {
        private static List<Disk> _disks;

        public DiskService()
        {
            _disks = new List<Disk>();
            _disks.Add(new Disk(1, "Souldier", "Jain", new DateTime(2018, 08, 24)));
            _disks.Add(new Disk(2, "Origins", "Imagine Dragons", new DateTime(2018, 11, 09)));
            _disks.Add(new Disk(3, "En amont", "Alain Bashung", new DateTime(2018, 11, 23)));
            _disks.Add(new Disk(4, "La vie de rêve", "Bigflo et Oli", new DateTime(2018, 11, 23)));
        }

        private int GetNextId()
        {
            return _disks.Max(x => x.Id) + 1;
        }

        public IEnumerable<Disk> GetAll()
        {
            return _disks.Select(x => x);
        }

        public Disk Find (int? id)
        {
            return _disks.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Disk disk)
        {
            Disk newDisk = new Disk(GetNextId(), disk.Titre, disk.Interprete, disk.DateSortie);
            _disks.Add(newDisk);
        }
        
        public Disk Update(Disk newDisk)
        {
            Remove(newDisk);
            _disks.Add(newDisk);
            return newDisk;
        }
        
        public void Remove(Disk disk)
        {
            _disks.Remove(_disks.FirstOrDefault(x => x.Id == disk.Id));
        }
    }
}