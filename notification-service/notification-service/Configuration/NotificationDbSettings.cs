﻿namespace notification_service.Configuration
{
    public class NotificationDbSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public string NotificationsCollectionName { get; set; } = string.Empty;
        public string UserNotificationsCollectionName { get; set; } = string.Empty;
    }
}
