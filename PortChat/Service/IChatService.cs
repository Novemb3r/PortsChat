﻿using PortChat.Presenter;
using PortChat.Service.DTO;
using static PortChat.Constants;

namespace PortChat.Service
{
    public interface IChatService
    {
        void InitHook(ChatPresenter chatPresenter);
        string RecieveData();

        void WriteData(TransmissionMode transmissionMode, ValidationMode validationMode, string msg);

        void OpenConnection(ConnectionDTO connection);

        void CloseConnection();
    }
}
