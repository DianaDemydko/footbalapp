﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Services.DTO;

namespace ServerApp.Services.Interfaces
{
    public interface ITeamServise : IDisposable
    {
        void CreateTeam(TeamDTO teamDTO);
        void AddPlayer(int teamId, int userId);
        void RemovePlayer(int userId);

        void RemoveTeam(int teamId);
        void ChangeTeamName(int teamId, string newTeamName);

        IEnumerable<TeamDTO> GetAllTeams();

        IEnumerable<UserDTO> GetAllTeamMembers(int teamId);

        TeamDTO GetTeamById(int teamId);

        IEnumerable<RoleDTO> GetTeamRoles();

        void ChangePlayerRole(int userId, int roleId);
    }
}
