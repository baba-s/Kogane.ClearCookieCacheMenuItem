using UnityEditor;
using UnityEngine.Networking;

namespace Kogane.Internal
{
    internal static class ClearCookieCacheMenuItem
    {
        [MenuItem( "Kogane/UnityWebRequest/Clear Cookie Cache" )]
        private static void ClearCookieCache()
        {
            var isOk = EditorUtility.DisplayDialog
            (
                title: "",
                message: "UnityWebRequest の ClearCookieCache を実行しますか？",
                ok: "はい",
                cancel: "いいえ"
            );

            if ( !isOk ) return;

            UnityWebRequest.ClearCookieCache();

            EditorUtility.DisplayDialog
            (
                title: "",
                message: "UnityWebRequest の ClearCookieCache を実行しました",
                ok: "OK"
            );
        }
    }
}