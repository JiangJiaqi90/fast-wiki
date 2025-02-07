﻿namespace FastWiki.Service.Contracts.ChatApplication.Dto;

public class ChatDialogDto
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string ChatId { get; set; }

    public string Description { get; set; }

    public ChatDialogType Type { get; set; }

    public string TypeName
    {
        get
        {
            switch (Type)
            {
                case ChatDialogType.ChatApplication:
                    return "应用对话";
                case ChatDialogType.ChatShare:
                    return "分享对话";
            }

            return "错误状态";
        }
    }
}