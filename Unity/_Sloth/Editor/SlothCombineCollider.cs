﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SlothCombineCollider : Editor
{

    #region Level 2
    [MenuItem("Sloth/CombineCollider/L2/CombineBigCollider_grid_12")]
    static void CombineBigCollider_grid_12()
    {
        CombineColliderUtil_2.CombineBigCollider_grid_12();
    }
    [MenuItem("Sloth/CombineCollider/L2/ClearCombineBigCollider_grid_12")]
    static void ClearCombineBigCollider_grid_12()
    {
        CombineColliderUtil.ClearCombineBigColliderChilders("Waltz_Tile_Empty1x1_grid_12");
    }

    [MenuItem("Sloth/CombineCollider/L2/CombineBigCollider_grid_13")]
    static void CombineBigCollider_grid_13()
    {
        CombineColliderUtil_2.CombineBigCollider_grid_13();
    }
    [MenuItem("Sloth/CombineCollider/L2/ClearCombineBigCollider_grid_13")]
    static void ClearCombineBigCollider_grid_13()
    {
        CombineColliderUtil.ClearCombineBigColliderChilders("Waltz_Tile_Empty1x1_grid_13");
    }

    [MenuItem("Sloth/CombineCollider/L2/CombineBigCollider_grid_14")]
    static void CombineBigCollider_grid_14()
    {
        CombineColliderUtil_2.CombineBigCollider_grid_14();
    }
    [MenuItem("Sloth/CombineCollider/L2/ClearCombineBigCollider_grid_14")]
    static void ClearCombineBigCollider_grid_14()
    {
        CombineColliderUtil.ClearCombineBigColliderChilders("Waltz_Tile_Empty1x1_grid_14");
    }

    [MenuItem("Sloth/CombineCollider/L2/CombineBigCollider_grid_15")]
    static void CombineBigCollider_grid_15()
    {
        CombineColliderUtil_2.CombineBigCollider_grid_15();
    }
    [MenuItem("Sloth/CombineCollider/L2/ClearCombineBigCollider_grid_15")]
    static void ClearCombineBigCollider_grid_15()
    {
        CombineColliderUtil.ClearCombineBigColliderChilders("Waltz_Tile_Empty1x1_grid_15");
    }

    [MenuItem("Sloth/CombineCollider/L2/CombineBigCollider_grid_16")]
    static void CombineBigCollider_grid_16()
    {
        CombineColliderUtil_2.CombineBigCollider_grid_16();
    }
    [MenuItem("Sloth/CombineCollider/L2/ClearCombineBigCollider_grid_16")]
    static void ClearCombineBigCollider_grid_16()
    {
        CombineColliderUtil.ClearCombineBigColliderChilders("Waltz_Tile_Empty1x1_grid_16");
    }
    #endregion

    #region Level 3
    [MenuItem("Sloth/CombineCollider/L3/CombineCollider_MoveAllDirTile")]
    static void CombineCollider_MoveAllDirTile()
    {
        CombineColliderUtil_Select.CombineCollider_Tile_XiaoZhen_Move_Water();
    }

    [MenuItem("Sloth/CombineCollider/L3/ClearCombineOldCollider")]
    static void ClearCombineOldCollider_L3()
    {
        CombineColliderUtil_Select.ClearCombineOldColliderMoveAllDirTile();
    }

    [MenuItem("Sloth/CombineCollider/L3/---------转 NormalTile--------")]
    static void tttt_1() { }

    [MenuItem("Sloth/CombineCollider/L3/AnimEnemy2MoveAllDirTileNew")]
    static void AnimEnemy2MoveAllDirTileNew()
    {
        CombineColliderUtil.AnimEnemy2MoveAllDirTileNew();
    }
    [MenuItem("Sloth/CombineCollider/MoveAllDirTile_move_forward")]
    static void MoveAllDirTile_Change_WideTilePro_forward()
    {
        CombineColliderUtil.Move_MoveAllDirTile_Distance(true, Selection.transforms);
    }
    [MenuItem("Sloth/CombineCollider/L3/MoveAllDirTile_Change_NormalTile")]
    static void MoveAllDirTile_Change_NormalTile()
    {
        CombineColliderUtil.MoveAllDirTile_Change_NormalTile();
    }
    [MenuItem("Sloth/CombineCollider/MoveAllDirTile_move_back")]
    static void MoveAllDirTile_Change_WideTilePro_back()
    {
        CombineColliderUtil.Move_MoveAllDirTile_Distance(false, Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/L3/------NormalTile 合 WideTilePro-----------")]
    static void tttt_2() { }

    [MenuItem("Sloth/CombineCollider/L3/SelectCombineColliderAddWideTilePro")]
    static void SelectCombineColliderAddWideTilePro()
    {
        CombineColliderUtil.SelectCombineColliderAddWideTilePro();
    }
    [MenuItem("Sloth/CombineCollider/L3/ClearCombineColliderAddWideTilePro")]
    static void ClearCombineColliderAddWideTilePro()
    {
        CombineColliderUtil.ClearCombineColliderAddWideTilePro();
    }

    [MenuItem("Sloth/CombineCollider/L3/------EmissionTile 合 WideTilePro-----------")]
    static void tttt_3() { }

    [MenuItem("Sloth/CombineCollider/L3/CombineCollider_EmissionTile")]
    static void CombineCollider_EmissionTile()
    {
        CombineColliderUtil_3_NormalTile.CombineCollider_EmissionTile();
    }
    #endregion

    #region Level 4
    [MenuItem("Sloth/CombineCollider/L4/Combine block FreeCollideTile")]
    static void Combine_block_FreeCollideTile()
    {
        CombineUtil_4_1.Combine_block_FreeCollideTile(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/L4/Combine block WideTilePro Anomaly")]
    static void Combine_block_WideTilePro_Anomaly()
    {
        CombineUtil_4_1.Combine_block_WideTilePro_Anomaly(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/L4/MoveAllDirTile Change NormalTile")]
    static void Combine_block_MoveAllDirTile_change_NormalTile()
    {
        CombineUtil_4_1.Combine_block_MoveAllDirTile_change_NormalTile(Selection.transforms);
    }
    [MenuItem("Sloth/CombineCollider/L4/MoveAllDirTile Remove Collider")]
    static void Combine_block_MoveAllDirTile_remove_collider()
    {
        CombineUtil_4_1.Combine_block_MoveAllDirTile_change_NormalTile(Selection.transforms, false);
    }
    [MenuItem("Sloth/CombineCollider/L4/NormalTile Change WideTipePro")]
    static void Combine_block_NormalTile_Change_WideTipePro()
    {
        CombineUtil_4_1.Combine_block_NormalTile_Change_WideTipePro(Selection.transforms);
    }
    #endregion

    #region Level 5
    [MenuItem("Sloth/CombineCollider/L5/MoveAllDirTile Change NormalTile")]
    static void Combine_block_MoveAllDirTile_change_NormalTile_5()
    {
        CombineUtil_5_1.Combine_block_MoveAllDirTile_change_NormalTile(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/L5/NormalTile Change WideTipePro")]
    static void Combine_block_NormalTile_Change_WideTipePro_5()
    {
        CombineUtil_4_1.Combine_block_NormalTile_Change_WideTipePro(Selection.transforms, "Midground");
    }

    #endregion

    #region Level 6

    [MenuItem("Sloth/CombineCollider/L6/EmissionTile Change NormalTile")]
    static void Combine_block_EmissionTile_change_NormalTile_6()
    {
        CombineUtil_6_1.Combine_Collider_EmissionTile_2_NormalTile(Selection.transforms);
    }
    //先执行 MoveAllDirTile_move_forward
    //完事后 MoveAllDirTile_move_back
    //针对 。x=5 * z=1 长条。
    [MenuItem("Sloth/CombineCollider/L6/MoveAllDirTile Change WideTilePro 5x1")]
    static void Combine_block_MoveAllDirTile_change_NormalTile_6()
    {
        CombineUtil_6_1.Combine_Collider_MoveAllDirTile_2_WideTilePro_5x1(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/L6/Change WideTilePro LocalScale To One")]
    static void ChangeWideTileProLocalScaleToOne()
    {
        CombineUtil_6_1.ChangeWideTileProLocalScaleToOne(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/L6/Combine block WideTilePro Anomaly")]
    static void Combine_block_WideTilePro_Anomaly_6()
    {
        CombineUtil_6_1.Combine_block_WideTilePro_Anomaly(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/L6/Destroy Tag Gameobject")]
    static void EndDestroyTagGameobject_6()
    {
        CombineUtil_6_1.EndDestroyTagGameobject();
    }

    [MenuItem("Sloth/CombineCollider/L6/Remove Tag Gameobject")]
    static void RemoveTagGameobject_6()
    {
        CombineUtil_6_1.tagDestroyGos = new List<Transform>();
    }

    #endregion

    #region Waltz_1_E
    [MenuItem("Sloth/CombineCollider/Waltz_1_E/Combine block FreeCollideTile")]
    static void Combine_block_FreeCollideTile_Waltz_1_E()
    {
        CombineUtil_Waltz_1_E.Combine_block_FreeCollideTile(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/Waltz_1_E/Combine NormalTile 2 WideTilePro")]
    static void Combine_block_NormalTile_2_WideTilePro_Waltz_1_E()
    {
        CombineUtil_Waltz_1_E.Combine_block_NormalTile_2_WideTipePro(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/Waltz_1_E/Combine WideTilePro block")]
    static void Combine_WideTileProTo_Block()
    {
        CombineUtil_Waltz_1_E.Combine_WideTileProTo_Block(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/Waltz_1_E/Combine WideTilePro block Anomaly")]
    static void Combine_block_WideTilePro_Anomaly_Waltz_1_E()
    {
        CombineUtil_Waltz_1_E.Combine_block_WideTilePro_Anomaly(Selection.transforms);
    }

    #endregion

    #region Jazz_E

    [MenuItem("Sloth/CombineCollider/Jazz_E/Combine MultiSegmentAnimationTile To NormalTile Block")]
    static void Combine_MultiSegmentAnimationTile_To_NormalTile_Block()
    {
        CombineUtil_Jazz_E.Combine_MultiSegmentAnimationTile_To_NormalTile_Block(Selection.transforms);
    }

    #endregion

    #region Thief_2_H

    [MenuItem("Sloth/CombineCollider/Thief_2_H/Combine FreeCollideTile Block")]
    static void Combine_block_FreeCollideTile_Thief_2_H()
    {
        CombineUtil_Thief_2_H.Combine_block_FreeCollideTile(Selection.transforms);
    }

    [MenuItem("Sloth/CombineCollider/Thief_2_H/Combine EmissionTile Block %g")]
    static void Combine_block_EmissionTile_Thief_2_H()
    {
        CombineUtil_Thief_2_H.Combine_block_EmissionTile(Selection.transforms);
    }
    

    #endregion

}
