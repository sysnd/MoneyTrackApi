using MoneyTrack.Data.Models;
using MoneyTrack.Data.Repositories.AlertsRepository;
using System.Collections.Generic;

namespace MoneyTrack.Services.AlertsService
{
    public class AlertService :IAlertService
    {
        private readonly IAlertRepository alertsRepository;
        public AlertService(IAlertRepository alertsRepository)
        {
            this.alertsRepository = alertsRepository;
        }
        public List<Alert> Get()
        {
            return alertsRepository.Get();
        }
        public Alert Get(string id)
        {
            return alertsRepository.Get(id);
        }
        public Alert Create(Alert alert)
        {
            return alertsRepository.Create(alert);
        }

        public bool Update(string id, Alert alert)
        {
            return alertsRepository.Update(id, alert);
        }

        public bool Remove(Alert alert)
        {
            return alertsRepository.Remove(alert);
        }

        public bool Remove(string id)
        {
            return alertsRepository.Remove(id);
        }
    }
}
