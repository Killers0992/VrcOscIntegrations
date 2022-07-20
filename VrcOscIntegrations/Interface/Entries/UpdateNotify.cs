using VrcOscIntegrations.Services;

namespace VrcOscIntegrations.Interface.Entries
{
    public partial class UpdateNotify : PoisonUserControl
    {
        List<PendingUpdate> _updates;
        int _currentIndex = 0;

        public UpdateNotify(List<PendingUpdate> updates)
        {
            _updates = updates;
            InitializeComponent();
            nextUpdate.Visible = _updates.Count > 1;
            previousUpdate.Visible = _updates.Count > 1;
            updatesCount.Text = _updates.Count.ToString();
            updatesText.Text = _updates.Count > 1 ? "Found      updates !" : "Found      update !";
            RenderUpdate(_updates[0]);
        }

        string _updateInfo;
        public string UpdateInfo
        {
            get
            {
                return _updateInfo;
            }
            set
            {
                _updateInfo = value;
                updateInfo.Text = value;
            }
        }

        string _oldVersion;
        public string OldVersion
        {
            get
            {
                return _oldVersion;
            }
            set
            {
                _oldVersion = value;
                oldVersion.Text = value;
            }
        }

        string _newVersion;
        public string NewVersion
        {
            get
            {
                return _newVersion;
            }
            set
            {
                _newVersion = value;
                newVersion.Text = value;
            }
        }

        string _changelogs;
        public string ChangeLogs
        {
            get
            {
                return _changelogs;
            }
            set
            {
                _changelogs = value;
                changelogs.Text = value;
            }
        }

        private void nextUpdate_Click(object sender, EventArgs e)
        {
            _currentIndex = _currentIndex == _updates.Count - 1 ? 0 : _currentIndex + 1;
            RenderUpdate(_updates[_currentIndex]);
        }

        private void previousUpdate_Click(object sender, EventArgs e)
        {
            _currentIndex = _currentIndex == 0 ? _updates.Count - 1 : 0;
            RenderUpdate(_updates[_currentIndex]);
        }

        void RenderUpdate(PendingUpdate update)
        {
            UpdateInfo = update.DisplayName;
            OldVersion = update.CurrentVersion;
            NewVersion = update.NewVersion;
            ChangeLogs = string.Join("\n", update.Changelogs);
            UpdateButons(UpdateState.AfterRestart, UpdateState.None, true);
            UpdateButons(UpdateState.UpdateNow, UpdateState.None, true);
            UpdateButons(UpdateState.Ignore, UpdateState.None, true);
            UpdateButons(UpdateState.None, update.UpdateState, true);
        }

        private void done_Click(object sender, EventArgs e)
        {
            AutoUpdater.ReadyUpdate = _updates.Where(x => x.UpdateState == UpdateState.UpdateNow).ToList();
            ParentForm.Close();
        }

        void UpdateButons(UpdateState oldValue, UpdateState newValue, bool raw = false)
        {
            if (oldValue != newValue)
            {
                switch (oldValue)
                {
                    case UpdateState.UpdateNow:
                        updateNow.Colors[7].ValueHex = "#232323";
                        break;
                    case UpdateState.Ignore:
                        ignore.Colors[7].ValueHex = "#232323";
                        break;
                    case UpdateState.AfterRestart:
                        afterRestart.Colors[7].ValueHex = "#232323";
                        break;
                }
            }

            switch (newValue)
            {
                case UpdateState.UpdateNow:
                    updateNow.Colors[7].ValueHex = oldValue == newValue ? "#232323" : "#00FF00";
                    break;
                case UpdateState.Ignore:
                    updateNow.Colors[7].ValueHex = oldValue == newValue ? "#232323" : "#232323";
                    break;
                case UpdateState.AfterRestart:
                    afterRestart.Colors[7].ValueHex = oldValue == newValue ? "#232323" : "#232323";
                    break;
            }

            if (raw) return;

            _updates[_currentIndex].UpdateState = oldValue == newValue ? UpdateState.None : newValue;

            int confirmLeft = _updates.Where(x => x.UpdateState == UpdateState.None).Count();
            updatesTodo.Text = confirmLeft == 0 ? String.Empty : $"You need to confirm {confirmLeft} other updates !";
            done.UseWaitCursor = confirmLeft != 0;
            done.Colors[7].ValueHex = confirmLeft == 0 ? "#232323" : "##FF0000";
        }

        private void updateNow_Click(object sender, EventArgs e)
        {
            UpdateButons(_updates[_currentIndex].UpdateState, UpdateState.UpdateNow);
        }

        private void afterRestart_Click(object sender, EventArgs e)
        {
            UpdateButons(_updates[_currentIndex].UpdateState, UpdateState.AfterRestart);
        }

        private void ignore_Click(object sender, EventArgs e)
        {
            UpdateButons(_updates[_currentIndex].UpdateState, UpdateState.Ignore);
        }
    }
}
