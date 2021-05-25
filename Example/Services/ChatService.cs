using System;
using System.Collections.Generic;
using Moq;
using Roles.Employees;

namespace Roles.Services
{
    /// <summary>
    /// Сервис выдачи списка чатов
    /// </summary>
    class ChatService : IChat
    {
        #region Поля

        /// <summary>
        /// Конвертер остальных периодов
        /// </summary>
        public static Dictionary<string, string> ChatList = new() 
        {
            {nameof(Programmer), "ProgrammersChat, GitLabChat, SpeakingChat" },
            {nameof(Manager), "ManagersChat, SpeakingChat" },
            {nameof(Analyst), "AnalystsChat, SpeakingChat" },
        };

        #endregion

        #region Конструктор

        public ChatService() { }

        #endregion

        #region Методы

        public string GetChats(string phone, string post)
        {
            return ChatList[post]; //stub
        }

        #endregion
    }
}
