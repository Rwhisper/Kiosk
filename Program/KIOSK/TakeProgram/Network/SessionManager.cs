using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeProgram
{
    class SessionManager
    {
        static SessionManager _session = new SessionManager();
        public static SessionManager Instance { get { return _session; } }
        /// <summary>
		/// 서버에 접속한 유저 정보
		/// </summary>
		Dictionary<int, Session> _sessions = new Dictionary<int, Session>();

		int _sessionId = 0;
        object _lock = new object();

		public void Generate(Session session)
		{
			lock (_lock)
			{
				int sessionId = ++_sessionId;

				session.SessionId = sessionId;
				_sessions.Add(sessionId, session);		

				
			}
		}

		/// <summary>
		/// 세션풀에서 세션 삭제
		/// </summary>
		/// <param name="session"></param>
		public void Remove(Session session)
		{
			lock (_lock)
			{
				_sessions.Remove(session.SessionId);
			}
		}
	}
}
