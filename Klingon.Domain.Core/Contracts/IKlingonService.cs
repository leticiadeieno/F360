﻿namespace Klingon.Domain.Core.Contracts
{
    public interface IKlingonService
    {
        int CountPrepositions(string[] list);

        int CountVerbs(string[] list);

        int CountVerbsInFirstPerson(string[] list);

        bool CheckIfIsPreposition(char lastCharacter);

        bool CheckIfIsFooOrBar(char character);
    }
}
