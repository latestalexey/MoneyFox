﻿using MoneyFox.Business.ViewModels;
using MoneyFox.Business.ViewModels.DesignTime;
using MoneyFox.Business.ViewModels.Statistic;

namespace MoneyFox.Business
{
    /// <summary>
    ///     Locator to provide Design Time ViewModels for the Xamarin Forms Designer.
    /// </summary>
    public static class DesignTimeViewModelLocator
    {
        private static IBackupViewModel BACKUP_VIEW_MODEL;
        private static IStatisticSelectorViewModel STATISTIC_SELECTOR_VIEW_MODEL;

        /// <summary>
        ///     Implementation for IBackupViewModel for design time.
        /// </summary>
        public static IBackupViewModel DesignTimeBackupViewModel =>
            BACKUP_VIEW_MODEL ?? (BACKUP_VIEW_MODEL = new DesignTimeBackupViewModel());

        /// <summary>
        ///     Implementation for IStatisticSelectorViewModel for design time.
        /// </summary>
        public static IStatisticSelectorViewModel DesignTimeStatisticSelectorViewModel =>
            STATISTIC_SELECTOR_VIEW_MODEL ?? (STATISTIC_SELECTOR_VIEW_MODEL = new DesignTimeStatisticSelectorViewModel());
    }
}
