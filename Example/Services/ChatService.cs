using System;
using System.Collections.Generic;
using Moq;
using Roles.Models;

namespace Roles.Services
{
    /// <summary>
    /// Сервис выдачи списка чатов
    /// </summary>
    class ChatService
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

        public IChat GetChats(Employee emp)
        {
            var mockService = new Mock<IChat>();

            mockService
                    .Setup(r => r.GetChats(emp.Phone, emp.Post))
                    .Returns(ChatList[emp.Post]);

            return mockService.Object;
        }

        #endregion
    }
}
