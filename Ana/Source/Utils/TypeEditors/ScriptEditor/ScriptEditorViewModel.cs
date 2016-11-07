﻿namespace Ana.Source.Utils.ScriptEditor
{
    using Docking;
    using Main;
    using Mvvm.Command;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    /// View model for the Script Editor
    /// </summary>
    internal class ScriptEditorViewModel : ToolViewModel
    {
        /// <summary>
        /// The content id for the docking library associated with this view model
        /// </summary>
        public const String ToolContentId = nameof(ScriptEditorViewModel);

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptEditorViewModel" /> class
        /// </summary>
        public ScriptEditorViewModel() : base("Script Editor")
        {
            this.ContentId = ScriptEditorViewModel.ToolContentId;
            this.UpdateScriptCommand = new RelayCommand<String>((script) => this.UpdateScript(script), (script) => true);

            Task.Run(() => MainViewModel.GetInstance().Subscribe(this));
        }

        public ICommand UpdateScriptCommand { get; set; }

        public String Script { get; private set; }

        public void UpdateScript(String script)
        {
            this.Script = script;
        }
    }
    //// End class
}
//// End namespace